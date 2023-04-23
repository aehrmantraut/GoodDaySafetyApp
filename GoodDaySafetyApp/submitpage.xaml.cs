using static System.Net.Mime.MediaTypeNames;

namespace GoodDaySafetyApp;

public partial class Submitpage : ContentPage
{
	
	public Submitpage()
	{
		
		InitializeComponent();
		Namelabel.Text ="Name: " + StartPage.name;
        SceneSafelabel.Text = "Can you make the scene safe: " + SceneSafe.value;
        ProjectNamelabel.Text = "Project name: " + ProjectName.projectname;
        ProjectLocationlabel.Text = "project location: " + ProjectLocation.projectLocation;
        DirectionalArealable.Text = "hazards directional area: " + DirectionalArea.directionalArea;
        UnsafeConditionlabel.Text = "Unsafe Conditions include: " + UnsafeConditions.allconditions;
        Commentslabel.Text = "comments: " + Comments.comments;
        


    }
    private void NextPage_Click(object sender, EventArgs e)
    {

        string saveReport = "INSERT into Report (MakeSafe, ProjectName, ProjectLocation, DirectionalArea, Conditions, Comments)" +
            "VALUES ('" + SceneSafe.value + "', '" + ProjectName.projectname + "', '" + ProjectLocation.projectLocation + "', '" + DirectionalArea.directionalArea + "', '" + UnsafeConditions.allconditions + "', '" + Comments.comments + "');";


       // SqlCommand querysaveReport = new SqlCommand(saveReport);
    }
}