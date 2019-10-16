#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ElitzurVaidmanBomb\",\"Name\":\"PrepareInjectorState\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ElitzurVaidmanBomb\",\"Name\":\"PrepareInjectorState\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ElitzurVaidmanBomb\",\"Name\":\"prepareBomb\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ElitzurVaidmanBomb\",\"Name\":\"prepareBomb\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ElitzurVaidmanBomb\",\"Name\":\"passThroughBomb\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"injector\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bomb\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ElitzurVaidmanBomb\",\"Name\":\"passThroughBomb\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ElitzurVaidmanBomb\",\"Name\":\"ElitZurVaidmanBomb\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ElitzurVaidmanBomb\",\"Name\":\"ElitZurVaidmanBomb\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
#line hidden
namespace ElitzurVaidmanBomb
{
    public partial class PrepareInjectorState : Operation<Qubit, QVoid>, ICallable
    {
        public PrepareInjectorState(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrepareInjectorState";
        String ICallable.FullName => "ElitzurVaidmanBomb.PrepareInjectorState";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var qubit = __in__;
#line 13 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
            MicrosoftQuantumIntrinsicH.Apply(qubit);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit qubit)
        {
            return __m__.Run<PrepareInjectorState, Qubit, QVoid>(qubit);
        }
    }

    public partial class prepareBomb : Operation<QVoid, Boolean>, ICallable
    {
        public prepareBomb(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "prepareBomb";
        String ICallable.FullName => "ElitzurVaidmanBomb.prepareBomb";
        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        public override Func<QVoid, Boolean> Body => (__in__) =>
        {
#line 17 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
            return (MicrosoftQuantumMathRandomInt.Apply(1L) == 0L);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__)
        {
            return __m__.Run<prepareBomb, QVoid, Boolean>(QVoid.Instance);
        }
    }

    public partial class passThroughBomb : Operation<(Qubit,Boolean), Int64>, ICallable
    {
        public passThroughBomb(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Boolean)>, IApplyData
        {
            public In((Qubit,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "passThroughBomb";
        String ICallable.FullName => "ElitzurVaidmanBomb.passThroughBomb";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicRy
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        public override Func<(Qubit,Boolean), Int64> Body => (__in__) =>
        {
            var (injector,bomb) = __in__;
#line 21 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
            var measurement = MicrosoftQuantumIntrinsicM.Apply(injector);
#line 23 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
            if ((measurement == Result.One))
            {
#line 24 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
                if (bomb)
                {
#line 27 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
                    return -(1L);
                }
                else
                {
#line 31 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
                    return 0L;
                }
            }
            else
            {
#line 37 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
                MicrosoftQuantumIntrinsicRy.Apply((((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 4D), injector));
#line 39 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
                var measurement_final = MicrosoftQuantumIntrinsicM.Apply(injector);
#line 40 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
                if ((measurement_final == Result.One))
                {
#line 41 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
                    return 1L;
                }

#line 43 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
                return 0L;
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
        }

        public override IApplyData __dataIn((Qubit,Boolean) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Qubit injector, Boolean bomb)
        {
            return __m__.Run<passThroughBomb, (Qubit,Boolean), Int64>((injector, bomb));
        }
    }

    public partial class ElitZurVaidmanBomb : Operation<QVoid, Boolean>, ICallable
    {
        public ElitZurVaidmanBomb(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ElitZurVaidmanBomb";
        String ICallable.FullName => "ElitzurVaidmanBomb.ElitZurVaidmanBomb";
        protected ICallable<Qubit, QVoid> PrepareInjectorState
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Boolean), Int64> passThroughBomb
        {
            get;
            set;
        }

        protected ICallable<QVoid, Boolean> prepareBomb
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        public override Func<QVoid, Boolean> Body => (__in__) =>
        {
#line 51 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
            var result = -(1L);
#line 52 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
            var bomb = false;
#line hidden
            {
#line 53 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
                var qubit = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 54 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
                    PrepareInjectorState.Apply(qubit);
#line 55 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
                    bomb = prepareBomb.Apply(QVoid.Instance);
#line 56 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
                    result = passThroughBomb.Apply((qubit, bomb));
#line 57 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(qubit);
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(qubit);
                }
            }

#line 60 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
            if (((result == 1L) && bomb))
            {
#line 61 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
                return true;
            }

#line 63 "C:/Users/pbhadekar/Q/ElitzurVaidmanBomb/Operations.qs"
            return false;
        }

        ;
        public override void Init()
        {
            this.PrepareInjectorState = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(PrepareInjectorState));
            this.passThroughBomb = this.Factory.Get<ICallable<(Qubit,Boolean), Int64>>(typeof(passThroughBomb));
            this.prepareBomb = this.Factory.Get<ICallable<QVoid, Boolean>>(typeof(prepareBomb));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__)
        {
            return __m__.Run<ElitZurVaidmanBomb, QVoid, Boolean>(QVoid.Instance);
        }
    }
}