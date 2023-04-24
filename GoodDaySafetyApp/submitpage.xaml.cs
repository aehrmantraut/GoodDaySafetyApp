using Microsoft.Maui.Controls;
using System.Data;
using System.Data.SqlClient;
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
        ReviewImage.Source = Picture.img;


    }
  
    
    
    
     private void NextPage_Click(object sender, EventArgs e)
    {
        using (SqlConnection connection = new SqlConnection("Server=tcp:gooddaysafety-test.database.windows.net,1433;Initial Catalog=Capstone-Test;Persist Security Info=False;User ID=gooddaysafety;Password=devPhase1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
        {
            string savedata = "INSERT INTO ReportTable (UserID, MakeSafe, ProjectName, ProjectLocation,DirectionalArea, Conditions,Comments) VALUES ('4','YES', 'CapStone',' QBB','W ', 'ELECTRICAL','Exposed wire' );";

                using (SqlCommand querySavedata = new SqlCommand (savedata))
                {
                querySavedata.Connection = connection;
                //  querySaveStaff.Parameters.Add("@staffName", SqlDbType.VarChar, 30).Value = name;

                connection.Open();

                querySavedata.ExecuteNonQuery();
            }



                /**    using (SqlConnection connection = new SqlConnection("Server = tcp:gooddaysafety - test.database.windows.net,1433; Initial Catalog = Capstone - Test; Persist Security Info = False; User ID = gooddaysafety; Password =devPhase1; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;            // <== lacking
                            command.CommandType = CommandType.Text;
                            command.CommandText = "INSERT INTO ReportTable (UserID, MakeSafe, ProjectName, ProjectLocation,DirectionalArea, Conditions,Comments) VALUES ('4','YES', 'CapStone',' QBB','W ', 'ELECTRICAL','Exposed wire' );";
                             

                            
                                /**= "INSERT into ReportTable (UserID, MakeSafe, ProjectName, ProjectLocation, DirectionalArea, Conditions ,Comments ,Attachment ) VALUES (@userID, @MakeSafe, @ProjectName, @ProjectLocation, @DirectionalArea, @Conditions ,@Comments, @Attachment)";
                            command.Parameters.AddWithValue("@userID", StartPage.name);
                            command.Parameters.AddWithValue("@MakeSafe", SceneSafe.value);
                            command.Parameters.AddWithValue("@ProjectName", ProjectName.projectname);
                            command.Parameters.AddWithValue("@ProjectLocation", ProjectLocation.projectLocation);
                            command.Parameters.AddWithValue("@DirectionalArea", DirectionalArea.directionalArea);
                            command.Parameters.AddWithValue("@Conditions", UnsafeConditions.allconditions);
                            command.Parameters.AddWithValue("@Conditions", Comments.comments);
                            command.Parameters.AddWithValue("@Attachment", Picture.img);
            **/

            }
        Microsoft.Maui.Controls.Application.Current.Quit();
    }
       

    

}