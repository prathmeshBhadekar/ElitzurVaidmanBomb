namespace ElitzurVaidmanBomb
{
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Intrinsic;
    
// prep |+> state
// Put randomly inside blackbox a filter, either nothing or (Blocks 1 --> Explodes, passes 1 without exploding)
// pass |+> through filter

    operation PrepareInjectorState(qubit  : Qubit) : Unit {
        H(qubit);
    }

    operation prepareBomb() : Bool {
        return RandomInt(1) == 0 ;
    }

    operation passThroughBomb(injector : Qubit, bomb : Bool) : Int {
        mutable measurement = M (injector) ;
        
        if(measurement == One) {
            if(bomb) {
                //Measured one, if there was really a bomb an explosion occured
                //exploded
                return -1 ;
            }
            else {
                //did not explode so must not be a bomb
                return 0 ;
            }
        } else {
            //state is |0> 
            //measuring in basis (|+>, |->)
            //make |0> |+> again
            Ry (2.0 * PI() / 4.0 , injector) ;
            //Measure |+> , if |0> it's not a bomb , if |1> it's a bomb!
            mutable measurement_final = M(injector) ;
            if(measurement_final == One) {
                return 1 ;
            }
            return 0 ;
        }
        // -1  - exploded
        // 0 - not a bomb
        // 1 - a bomb
    }

    operation ElitZurVaidmanBomb() : Bool {
        mutable result = -1 ;
        mutable bomb = false ;
        using(qubit = Qubit()) {
            PrepareInjectorState(qubit) ;
            set bomb = prepareBomb() ;
            set result = passThroughBomb(qubit, bomb) ;
            Reset(qubit);
        }
        //or (result == 0 and  bomb == false)
        if((result == 1 and bomb)) {
                return true ;
            }
            return false;
    }

}
