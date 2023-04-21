using System.Reflection.PortableExecutable;

namespace GoodDaySafetyApp;

public partial class UnsafeConditions : ContentPage
{
    public string allconditions;
    public string condition1;
    public string condition2;
    public string condition3;
    public string condition4;
    public string condition5;
    public string condition6;
    public string condition7;
    public string condition8;
    public string condition9;
    public string condition10;
    public string condition11;
    public string condition12;

    public UnsafeConditions()
    {
        InitializeComponent();
    }

    public string combinestring()
    {
        allconditions = condition1 + condition2 + condition3 + condition4 + condition5 + condition6 + condition7 + condition8 + condition9 + condition10 + condition11 + condition12 ;
        return allconditions;
    }
    
private void NextPage_Click(object sender, EventArgs e)
    {
        if (VehicleMachineToolbox.IsChecked)
        {
            condition1 = "Vehicle/Machine/Tool ";
        }
        if (electicalbox.IsChecked)
        {
            condition2 = "Electrical ";
        }
        if (flammableExplosivebox.IsChecked)
        {
            condition3 = "Flammable/Explosive ";
        }
        if (breathingbox.IsChecked)
        {
            condition4 = "Breathing ";
        }
        if (VehicleMachineToolbox.IsChecked)
        {
            condition5 = "Cutting/Stabbing ";
        }
        if (overheadbox.IsChecked)
        {   
            condition6 = "Overhead ";
        }
        if (struckHitbox.IsChecked)
        {
            condition7 = "Struck/Hit ";
        }
        if (ungaurdedEpeningEdgebox.IsChecked)
        {
            condition8 = "Ungaurded-opening/Edge ";
        }
        if (Unevenbox.IsChecked)
        {
            condition9 = "Uneven-surface/Tripping-hazard ";
        }
        if (slipperybox.IsChecked)
        {
            condition10 = "Slippery ";
        }
        if (unlitbox.IsChecked)
        {
            condition11 = "unlit area ";
        }
        if (otherbox.IsChecked)
        {
            condition12 = "see comments ";
        }
        //not sure how to make it so atleast one is checked
        combinestring();
        Navigation.PushAsync(new Comments());
    }
    
}