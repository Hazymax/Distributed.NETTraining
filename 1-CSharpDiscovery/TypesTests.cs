using System;
using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    [TestFixture]
    public class TypesTests
    {
        [Test]
        public void NFluentAndNUnitAreWorking()
        {
            Check.That(true).IsTrue();
        }

        [Test]
        public void AnIntIsNotEqualToSameIntStringRepresentation()
        {
            String str = "1";
            int i = 1;
            Check.That(str).Not.Equals(i);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsFloat()
        {
            float f = 1.7f;
            int i = 1;
            Check.That(f).Not.Equals(i);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsDouble()
        {
            double d = 1.7;
            int i = 1;
            Check.That(d).Not.Equals(i);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsDecimal()
        {
            decimal m = 300.5m;
            int i = 300;
            Check.That(m).Not.Equals(i);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsLong()
        {
            long entier32 = 1;
            int entier = 1;
            Check.That(entier32).Not.Equals(entier);
        }

        [Test]
        public void AnIntIsEqualToSameIntAsInt32()
        {
            int i = 1;
            Int32 i32 = 1;
            Check.That(i32).Equals(i);
        }

        [Test]
        public void AFloatCanBeCastedToInteger()
        {
            float single = 1.0F;
            int expectedInteger = 1;

            Check.That((int)single).Equals(expectedInteger);
        }

        [Test]
        public void AIntCanBeCastedToFloattttttttt()
        {
            int integer = 1;
            float expectedSingle = integer;

            Check.That(expectedSingle).Equals(1.0F);
        }

        [Test]
        public void AStringCanBeParsedToInteger()
        {
            string integerString = "30";
            int expectedInteger = 30;

            Check.That(int.Parse(integerString)).Equals(expectedInteger);
        }

        public void ParseFloatStringAsInteger()
        {
            float.Parse("30.0");
        }

        [Test]
        public void AFloatStringRepresentationCannotBeParsedToInteger()
        {
            // Create a method named ParseFloatStringAsInteger that takes no argument, return void and parse a float string representation "30.0"
            Check.ThatCode(ParseFloatStringAsInteger).Throws<FormatException>();
        }

        [Test]
        public void TryToParseAStringToInteger()
        {
            string floatString = "30.0";

            // Use int.TryParse, /!\ it uses an "out" argument
            int done;
            bool result = int.TryParse(floatString, out done);
            Check.That(done).Equals(0);
            Check.That(result).IsFalse();
        }

        [Test]
        public void UseVarForLessVerbosityButKeepStrongTyping()
        {
            var integerAsAString = "0";
            var integer = 0;
            Check.That(integerAsAString).Not.Equals(integer);
        }

        [Test]
        public void NullableIntWithNullValueDoesNotHaveValue()
        {
            // use "int?" to declare a nullable int initialized with null, then try also with Nullable<int>
            int? nullableInteger = null;
            Check.That(nullableInteger.HasValue).IsFalse();
        }

        public void GetNullableIntValue()
        {
            int? nullableInteger = null;
            int i = nullableInteger.Value;
        }

        [Test]
        public void GettingValueOfANullableIntwithNullValueThrowsAnInvalidOperationException()
        {
            // Create a method named GetNullableIntValue that takes no argument, return void and access a nullable int value (nullableInteger.Value)
            Check.That(GetNullableIntValue).Throws<InvalidOperationException>();
        }

        [Test]
        public void NullableIntWithNullValueDoesNotHaveValue1()
        {
            // use "int?" to declare a nullable int initialized with 30
            int? nullableInteger = 30;
            Check.That(nullableInteger.Value).Equals(30);
        }
    }
}
