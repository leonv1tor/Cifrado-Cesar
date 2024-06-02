namespace Cifrado.Tests;

public class UnitTest1
{
  [Fact]
   public void CifradoTest()
   {
   // Arrange
   string phrase = "Hola Mundo";
   int displacement = 3;
   string expectedResult = "Krod Pxqgr";
   // Act
   var result = Mathematics.Cifrado(phrase, displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }
   [Fact]
   public void CifradoTestInvalid()
   {
   // Arrange
   string phrase = "";
   int displacement = 3;
   // Act & Assert
   Assert.Throws<ArgumentException>(() => Mathematics.Cifrado(phrase, displacement));
   }
   [Fact]
   public void CifradoAutoTest()
   {
   // Arrange
   string phrase = "Hola Mundo";
   int displacement = 3;
   string expectedResult = "Krod Pxqgr";
   // Act
   var result = Mathematics.CifradoAuto(phrase, displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }
   [Fact]
   public void CifradoAutoTestInvalid()
   {
   // Arrange
   string phrase = "";
   int displacement = 3;
   // Act & Assert
   Assert.Throws<ArgumentException>(() => Mathematics.CifradoAuto(phrase, displacement));
   }

   [Fact]
   public void DecifradoTest()
   {
   // Arrange
   string phrase = "Krod Pxqgr";
   int displacement = 3;
   string expectedResult = "Hola Mundo";
   // Act
   var result = Mathematics.Decifrado(phrase, displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }
   [Fact]
   public void DecifradoTestInvalid()
   {
   // Arrange
   string phrase = "";
   int displacement = 3;
   // Act & Assert
   Assert.Throws<ArgumentException>(() => Mathematics.Decifrado(phrase, displacement));
   }
   [Fact]
   public void DecifradoAutoTest()
   {
   // Arrange
   // Simulamos que ya se han realizado cifrados antes
   Mathematics.CifradoAuto("Hola Mundo", 3);
   int displacement = 3;
   string expectedResult = "Hola Mundo";
   // Act
   var result = Mathematics.DecifradoAuto(displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }

   [Fact]
   public void DecifradoAutoTestInvalid()
   {
   // Arrange
   // Simulamos que no se ha realizado ningún cifrado antes
   Mathematics.CifradoAuto("Hola Mundo", 3);
   int displacement = 4;
   string expectedResult = "Krod Pxqgr";
   // Act
   var result = Mathematics.DecifradoAuto(displacement);
   // Assert
   Assert.NotEqual(expectedResult, result);
   }
}
