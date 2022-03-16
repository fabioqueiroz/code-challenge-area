using CodeChallengeArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeChalengeArea.Tests
{
    public class GenericLinkedListTests
    {
        [Fact]
        public void ElementsCanBe_Inserted_AtTheStart()
        {
            // Arrange
            var startLinkedList = new GenericLinkedList<int>();

            // Act
            startLinkedList.InsertAtStart(3);
            startLinkedList.InsertAtStart(2);
            startLinkedList.InsertAtStart(1);

            var firstElement = startLinkedList.Head.Data;

            // Assert
            Assert.Equal(1, firstElement);
        }

        [Fact]
        public void ElementsCanBe_Inserted_InTheMiddle()
        {
            // Arrange
            var linkedList = new GenericLinkedList<int>();

            // Act
            linkedList.InsertAtStart(1);
            linkedList.InsertAtTheEnd(2);
            linkedList.InsertInTheMiddle(3);

            var middleElement = linkedList.Head.Next.Data;

            // Assert
            Assert.Equal(3, middleElement);
        }

        [Fact]
        public void ElementsCanBe_Inserted_AtTheEnd()
        {
            // Arrange
            var linkedList = new GenericLinkedList<int>();

            // Act
            linkedList.InsertAtStart(1);
            linkedList.InsertAtTheEnd(2);
            linkedList.InsertInTheMiddle(3);

            var middleElement = linkedList.Head.Next.Next.Data;

            // Assert
            Assert.Equal(2, middleElement);
        }

        [Fact]
        public void ElementsCanBe_Removed_AtTheStart()
        {
            // Arrange
            var startLinkedList = new GenericLinkedList<int>();

            // Act
            startLinkedList.InsertAtStart(3);
            startLinkedList.InsertAtStart(2);
            startLinkedList.InsertAtStart(1);

            startLinkedList.RemoveAt(0);

            // Assert
            Assert.Equal(2, startLinkedList.Length);
        }

        [Fact]
        public void ElementsCanBe_Removed_FromTheMiddle()
        {
            // Arrange
            var startLinkedList = new GenericLinkedList<int>();

            // Act
            startLinkedList.InsertAtStart(3);
            startLinkedList.InsertAtStart(2);
            startLinkedList.InsertAtStart(1);

            startLinkedList.RemoveAt(1);

            // Assert
            Assert.Equal(2, startLinkedList.Length);
        }

        [Fact]
        public void ElementsCanBe_Removed_AtTheEnd()
        {
            // Arrange
            var startLinkedList = new GenericLinkedList<int>();

            // Act
            startLinkedList.InsertAtStart(3);
            startLinkedList.InsertAtStart(2);
            startLinkedList.InsertAtStart(1);

            startLinkedList.RemoveAt(2);

            // Assert
            Assert.Equal(2, startLinkedList.Length);
        }

        [Fact]
        public void IfTheIndex_IsOutOfBounds_AnExceptionIsThrow()
        {
            // Arrange
            var startLinkedList = new GenericLinkedList<int>();

            // Act
            startLinkedList.InsertAtStart(1);
            
            // Assert
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => startLinkedList.RemoveAt(1));
        }
    }
}
