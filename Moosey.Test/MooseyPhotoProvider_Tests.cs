using System;
using NUnit.Framework;

namespace Moosey.Test
{
    public class MooseyPhotoProvider_Tests
    {
        [Test]
        public void A_mooey_photo_can_be_retrieved()
        {
            // Arrange
            var sut = new MooseyPhotoProvider();

            // Act
            var result = sut.GetMostRecentMooseyPhotoSince(DateTime.Now);

            // Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}