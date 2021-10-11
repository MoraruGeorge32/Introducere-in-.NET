using System;
using System.IO;
namespace Main
{
    class Dry
    {
        private int[] information=new int[200];
        private int total;
        private string[] names = new string[200];
        private int minimumGoals;
        private int constantTemperature;

        public string[] loadingFile(string file){
            
            StreamReader input = new StreamReader(file,System.Text.Encoding.Default);
            string contents = input.ReadToEnd().Trim();
            string[] split = contents.Split('\n',StringSplitOptions.RemoveEmptyEntries);
            return split;
        }
        private string replaceElement(string word, string element){
                if(word.Contains(element))
                    word=word.Replace(element,String.Empty);
                return word;
        }
        public void parserInfo(string[] split, string element, int line1,int line2){
            int nrOfRows=0;
        for(int index=1; index<split.Length-1; index++){
               { string[] row = split[index].Split(' ',StringSplitOptions.RemoveEmptyEntries);
                row[line1] = replaceElement(row[line1],element);
                row[line2] = replaceElement(row[line2],element);
                int difference = Int32.Parse(row[line1])-Int32.Parse(row[line2]);
                if(row.Length>1)
                    this.names[nrOfRows]=row[1];
                this.information[nrOfRows++]=difference;}
                this.total=nrOfRows;
        }}
        public void constantDay(){
            this.constantTemperature=1000;
            constantTemperature=this.information[0];
            int dayNumber=1;
            for(int index=1; index<this.total; index++){
                if(this.information[index]<constantTemperature)
                {
                    constantTemperature=this.information[index];
                    dayNumber=index+1;
                }
            }
            Console.WriteLine("The smallest temperature spread and its day number: " + constantTemperature + " " + dayNumber);

    }

        public void weakestTeam(){
            minimumGoals=information[0];
            string teamName =names[0];
            for(int index=1; index<names.Length; index++)
                {
                    if(minimumGoals>information[index])
                    {
                        minimumGoals=information[index];
                        teamName=names[index];
                    }
                }
           Console.WriteLine("The smallest goal difference and its team: " + minimumGoals + " " + teamName);
}
}
}