using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace GoodDaySafetyApp;

public partial class UnsafeConditions : ContentPage
{
    public static string allconditions = "";
   

    public UnsafeConditions()
    {
        InitializeComponent();
    }

    public string Combinestring(string con)
    {
        allconditions +=  con;
        return allconditions;
    }
      
private void NextPage_Click(object sender, EventArgs e)
    {
        if (VehicleMachineToolbox.IsChecked)
        {
            Combinestring("Vehicle/Machine/Tool , ");
        }
        if (electicalbox.IsChecked)
        {     
            Combinestring("Electrical , ");
        }
        if (flammableExplosivebox.IsChecked)
        {
            Combinestring("Flammable/Explosive , ");
        }
            if (breathingbox.IsChecked)    
        {
            Combinestring("Breathing , ");
        }
        if (VehicleMachineToolbox.IsChecked)
        {
            Combinestring("Cutting/Stabbing , ");
        }
        if (overheadbox.IsChecked)
        {    
            Combinestring("Overhead , ");
        }
        if (struckHitbox.IsChecked)
        {
            Combinestring("Struck/Hit , ");
        }
        if (ungaurdedEpeningEdgebox.IsChecked)
        {
            Combinestring("Ungaurded-opening/Edge , ");
        }
        if (Unevenbox.IsChecked)
        {
            Combinestring("Uneven-surface/Tripping-hazard , ");
        }
        if (slipperybox.IsChecked)
        {
            Combinestring("Slippery , ");
        }
        if (unlitbox.IsChecked)
        {   
            Combinestring("unlit area , ");
        }
        if (otherbox.IsChecked)
        {
            Combinestring("see comments , ");
         }
        //not sure how to make it so atleast one is checked
       
            Navigation.PushAsync(new Comments());
        
    }
    
}