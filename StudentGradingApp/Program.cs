using System;
        

        int currentAssignments = 5;
       
       
        int[] sophia = { 90, 86, 87, 98, 100 };
        int[] andrew = {92,89,81,96,90};
        int[] emma = {90,85,87,98,68};
        int[] logan = {90,95,87,88,96};


  
     string[] studentNames = {"Sophia", "Andrew","Emma","Logan"};
     int[] studentScores = new int[10];

        // Write the Report Header to the console
    Console.WriteLine("Student\t\tGrade\n");

     foreach (string name in studentNames)
     {
        string currentStudent = name;

       if(currentStudent == "Sophia")
         studentScores = sophia;

        else if (currentStudent == "Andrew")
            studentScores = andrew;

        else if (currentStudent == "Emma")
            studentScores = emma;

        else if (currentStudent == "Logan")
            studentScores = logan;


            int SumAssignmentScores = 0;
            decimal currentStudentGrade = 0;

         foreach(int score in studentScores)
         {
            SumAssignmentScores += score;
         }
         currentStudentGrade = (decimal)SumAssignmentScores / currentAssignments;
        
       
        Console.WriteLine($"{currentStudent}\t\t {currentStudentGrade}\t");
     }
     
        
  








 