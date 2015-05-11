using NFluent;
using NUnit.Framework;
using System;

namespace Messaging.Tests.Domain
{
    [TestFixture]
    public class TimelineMessageTests
    {
        [Test]
        //public void WhenInstanciateTimelineMessage_ThenCanGetEachProperties()
        //{
        //    DateTime datetime = DateTime.Now;
        //    var timelineMessage = new TimelineMessage("OWNER", datetime,5,0,"");

        //     // TODO : add a check for each properties getter (NO SETTER ! => )
        //    Check.ThatCode(timelineMessage.Date).IsEqualTo(datetime);
        //    Check.ThatCode(timelineMessage.Nb_favoris).IsEqualTo(5);
        //    Check.ThatCode(timelineMessage.owner).IsEqualTo("OWNER");

        //}

        [Test]
        public void WhenInstanciateTwoTimelineMessageWithSameProperties_ThenTheyAreEquals()
        {
            var timelineMessage1 = new TimelineMessage(/* TODO add required properties in constructor parameters */);
            var timelineMessage2 = new TimelineMessage(/* TODO add required properties in constructor parameters */);

            Check.That(timelineMessage1).IsEqualTo(timelineMessage2);
        }
    }
}
