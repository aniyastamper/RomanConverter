using System.ComponentModel;
using NewRoman.Custom; 
namespace NewRoman;

public partial class MainPage : ContentPage
{
   public MainPage()
   {
      InitializeComponent();
      Title = "Old Roman Calculator";
   }

  //Create new instance of the 2 varaibles and it will pull the Conversion ito the class 
   

  
   
   private void ButtonRN_OnClicked(object sender, EventArgs e)
   {
     
      //Roman2Number - int 
      var romanToNumberConverter = new Converter(); 
      
      //Take our entry info and turn into var
      var Roman = int.TryParse(TxtRomanAndNumber.Text, out int number);
      
      //take roman var start Roman to number conversion
      romanToNumberConverter.RomanToNumber(TxtRomanAndNumber.Text);

      //Display the Converted roman to a Number in label 
     

   }
   
   private void CalculateNR_OnClicked(object sender, EventArgs e)
   {
      //Number2roman - string 
   
   }

   private void Clear_OnClicked(object sender, EventArgs e)
   {
      LblDisplay.Text = "";
      TxtRomanAndNumber.Text = "";
   }


}