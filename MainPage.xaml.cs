using System.ComponentModel;
using NewRoman.Custom; 
namespace NewRoman;



public partial class MainPage : ContentPage
{
   public static Converter ConverterCalc; //? Why is it greyed out, Should it be public partial 
   
   public MainPage()
   {
      InitializeComponent();
      Title = "Old Roman Calculator";
      ConverterCalc = new Converter(); //Converter calc is able to be used in main page Cs file
   }
  
   
   private void ButtonRN_OnClicked(object sender, EventArgs e)
   {
      
         //Roman2Number - int 
         var RomanToNumber = new Converter();
         
            //take roman var start Roman to number conversion
            LblDisplay.Text = RomanToNumber.RomanToNumber(TxtRomanToNumber.Text).ToString();
            

   }
   
   private void CalculateNR_OnClicked(object sender, EventArgs e)
   {
      //NumberToRoman
      
      var NumberToRoman = new Converter(); 
      
      //Take our entry info and turn into var
      var roman = int.TryParse(TxtNumberToRoman.Text, out int rnumber);
      
      //take roman var start Roman to number conversion
      LblDisplay.Text = NumberToRoman.NumberToRoman(rnumber);
      
    //  if (!string.IsNullOrEmpty(NumberToRoman.ToString()))
    //  {
     //    LblDisplay.Text = " Enter Valid Number";
    //  }
      
   }

   private void Clear_OnClicked(object sender, EventArgs e)
   {
      LblDisplay.Text = "";
      TxtRomanToNumber.Text = "";
      TxtNumberToRoman.Text = "";
   }


}