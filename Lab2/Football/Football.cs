using System;
using System.IO;
namespace Football
{
    class Football
    {
        private string[] teamNames = new string[150];
        private int[] goals = new int[150];
        private int minimumGoals;
        public Football()
        {
            int nrOfRows=0;
            StreamReader input = new StreamReader("D:\\football.dat",System.Text.Encoding.Default);
            string contents = input.ReadToEnd().Trim();
            string[] split = contents.Split('\n',StringSplitOptions.RemoveEmptyEntries);
            for(int index=1; index<split.Length; index++){
                string[] row = split[index].Split(' ',StringSplitOptions.RemoveEmptyEntries);
                if(row.Length>1){
                    this.teamNames[nrOfRows]=row[1];
                    this.goals[nrOfRows++] = Int32.Parse(row[6])-Int32.Parse(row[8]);
                }
            }
        }
        public void weakestTeam(){
            minimumGoals=goals[0];
            string teamName = teamNames[0];
            for(int index=1; index<teamNames.Length; index++)
                {
                    if(minimumGoals>goals[index])
                    {
                        minimumGoals=goals[index];
                        teamName=teamNames[index];
                    }
                }
            Console.WriteLine("The smallest goal difference and its team: " + minimumGoals + " " + teamName);
        }
    }
}
