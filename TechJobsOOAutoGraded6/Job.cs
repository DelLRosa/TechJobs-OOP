﻿using System;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.
            public Job()
            {
                Id = nextId;
                nextId++;
            }

            public Job(string name, Employer employer, Location location, PositionType type, CoreCompetency competency) : this ()
            {
                Name = name; 
                EmployerName = employer;
                EmployerLocation = location;
                JobType =type;
                JobCoreCompetency = competency;

            }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  
        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.





    }
}

