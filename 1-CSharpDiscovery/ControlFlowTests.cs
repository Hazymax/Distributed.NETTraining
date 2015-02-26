using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    [TestFixture]
    public class ControlFlowTests
    {
        [Test]
        public void UseForToConcatenateStringArrayValues()
        {
            var stringArray = new[] { "plip", "plop", "plup" };
            // concatenate string array values in a single string with the simplest solution using a for, then refactor (but keep for loop) using StringBuilder (+ avoid "", use string.Empty instead) for memory usage reason
            var stringConcatenated = "";
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringConcatenated = stringConcatenated + stringArray[i];
            }
            Check.That(stringConcatenated).Equals("plipplopplup");
        }

        [Test]
        public void UseForeachToConcatenateStringArrayValues()
        {
            var stringConcatenated = "";
            var stringArray = new[] { "plip", "plop", "plup" };
            foreach (var str in stringArray)
            {
                stringConcatenated = stringConcatenated + str;
            }

            // concatenate string array values in a single string with the simplest solution using a foreach

            Check.That(stringConcatenated).Equals("plipplopplup");
        }

        [Test]
        public void UseWhileToConcatenateStringArrayValues()
        {
            var stringArray = new[] { "plip", "plop", "plup" };
            int i =0;
            var stringConcatenated = "";
            // concatenate string array values in a single string with the simplest solution using a while
            while (i < stringArray.Length)
            {
                stringConcatenated = stringConcatenated + stringArray[i++];
            }
            Check.That(stringConcatenated).Equals("plipplopplup");
        }

        [Test]
        public void UseDoWhileToConcatenateStringArrayValues()
        {
            var stringArray = new[] { "plip", "plop", "plup" };
            // concatenate string array values in a single string with the simplest solution using a foreach
            int i = 0;
            var stringConcatenated = "";
            do
            {
                stringConcatenated = stringConcatenated + stringArray[i];
            } while (i < stringArray.Length);

            Check.That(stringConcatenated).Equals("plipplopplup");
        }

        //[Test]
        //public void UseIfElseElseIfDuringConcatenationOfStringArrayValues()
        //{
        //    var stringArray = new[] { "plip", "plop", "plup", "foo" };
        //    // concatenate a string, with "good, " when item is plip, "not so good, " when item starts with "pl", "bad, " in any other case
        //    int i = 0;
        //    var stringConcatenated = "";
        //    if (i < stringArray.Length){
        //        stringConcatenated = stringConcatenated + stringArray[i++];
        //    }

        //    Check.That(stringConcatenated).Equals("good, not so good, not so good, bad, ");
        //}

        //[Test]
        //public void UseSwitchCaseDuringConcatenationOfStringArrayValues()
        //{
        //    var stringArray = new[] { "plip", "plop", "plup", "foo" };
        //    // concatenate a string, with "good, " when item is plip, "not so good, " when item is "plop", "plip", "bad, " in any other case
        //    Check.That(stringConcatenated).Equals("good, not so good, not so good, bad, ");
        //}
    }
}
