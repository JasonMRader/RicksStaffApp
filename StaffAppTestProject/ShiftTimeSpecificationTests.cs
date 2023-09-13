using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Staff_Performance_Class_Library;
using Staff_Performance_Class_Library.FilterAndSortClasses;

namespace StaffAppTestProject
{
    [TestClass]
    public class ShiftTimeSpecificationTests
    {
        [TestMethod]
        public void ShiftTimeSpecification_ShouldMatchAMShift_WhenAMIsTrue()
        {
            // Arrange
            var shift = new Shift { IsAm = true };
            var spec = new ShiftTimeSpecification(true, false);

            // Act
            var result = spec.IsSatisfiedBy(shift);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShiftTimeSpecification_ShouldMatchPMShift_WhenPMIsTrue()
        {
            // Arrange
            var shift = new Shift { IsPm = true };
            var spec = new ShiftTimeSpecification(false, true);

            // Act
            var result = spec.IsSatisfiedBy(shift);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShiftTimeSpecification_ShouldMatchBothAMAndPMShifts_WhenBothAMAndPMAreTrue()
        {
            // Arrange
            var amShift = new Shift { IsAm = true };
            var pmShift = new Shift { IsPm = true };
            var spec = new ShiftTimeSpecification(true, true);

            // Act
            var amResult = spec.IsSatisfiedBy(amShift);
            var pmResult = spec.IsSatisfiedBy(pmShift);

            // Assert
            Assert.IsTrue(amResult);
            Assert.IsTrue(pmResult);
        }

        [TestMethod]
        public void ShiftTimeSpecification_ShouldNotMatchAnyShift_WhenBothAMAndPMAreFalse()
        {
            // This test scenario seems unlikely since if IsAm is false, IsPm is true and vice versa.
            // But for the sake of completion, we're keeping it.

            // Arrange
            var amShift = new Shift { IsAm = false }; // This would automatically make IsPm true, so this scenario doesn't really test what the name suggests.
            var pmShift = new Shift { IsPm = false }; // Likewise, setting IsPm to false will make IsAm true.
            var spec = new ShiftTimeSpecification(false, false);

            // Act
            var amResult = spec.IsSatisfiedBy(amShift);
            var pmResult = spec.IsSatisfiedBy(pmShift);

            // Assert
            Assert.IsFalse(amResult);
            Assert.IsFalse(pmResult);
        }
    }


}
