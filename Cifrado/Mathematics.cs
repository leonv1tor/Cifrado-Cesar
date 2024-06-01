namespace Cifrado;

public static class Mathematics
{
 public static double Esfera(double num1) { 
  
 double ans = (4.0/3.0) * Math.PI * Math.Pow(num1, 3);
 
 return ans;
 }
 public static double Lote(double num1, double num2) {  

 double ans2 = num1 * num2;
 
 return ans2;
 }
 public static double Edificio(double num1, double num2) {  
 
  double alphagrados = num2 * (Math.PI/180.0);
  double tanalpha =Math.Tan(alphagrados); 

 double ans3 = num1 * tanalpha;

 return ans3;
 }
}
