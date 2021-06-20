## Elitzur Vaidman Strategy

This repository uses Quantum Strategy to play the Elitzur Vaidman-Bomb game  
Built using Q# - Microsoft's Language for Quantum Computing.

### Game
The game asks you to guess whether there is a Bomb or not inside a given Black Box. 
The way to test is :

#### Classical 0 bit
If you pass inside a classical bit - 0 nothing happens and you get 0 from the receiving end 
of the box regardless of the bomb present/ not present inside .

#### Classical 1 bit
But if you pass a classical 1 bit inside, and if there's a Bomb, it explodes.
You need to determine whether there is a bomb inside or not, without it being exploded.

Classical strategy fails at this test, you pass a 1 and if there's a bomb it explodes, if you pass 0, 
you cannot gain any information about the bomb.

### Quantum Strategy
If we pass in a `|+>` state:
- In case of empty blackbox, we get back `|+>`
- In case of a bomb, it will explode 50% of the time when `|+>` collapses to state `|1>`
- In the remaninig 50% of the time, when we get a `|0>` if we measure the state in basis `|+>, |->`, on receiving a `|->`
we can be sure that it was the bomb.
This strategy is successful 25% of the time.

