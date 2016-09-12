// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using UIComposition.EmployeeModule.Models;

namespace UIComposition.EmployeeModule.Services
{
    /// <summary>
    /// Dummy employee data service class. Provides dummy data for employees and projects.
    /// Replace with your real employee data access or employee data service proxy.
    /// </summary>
    public class EmployeeDataService : IEmployeeDataService
    {
        private List<Employee> employees;
        private List<Project> projects;

        public List<Employee> GetEmployees()
        {
            if (this.employees == null)
            {
                // Dummy Data.
                this.employees = new List<Employee>
                                      {
                                          new Employee()
                                              {
                                                  Id = "1",
                                                  FirstName = "John",
                                                  LastName = "Smith",
                                                  Phone = "(425) 555 8912",
                                                  Email = "John.Smith@Contoso.com"
                                              },
                                          new Employee()
                                              {
                                                  Id = "2",
                                                  FirstName = "Bonnie",
                                                  LastName = "Skelly",
                                                  Phone = "(206) 555 7301",
                                                  Email = "Bonnie.Skelly@Contoso.com"
                                              },
                                          new Employee()
                                              {
                                                  Id = "3",
                                                  FirstName = "Dana",
                                                  LastName = "Birkby",
                                                  Phone = "(425) 555 7492",
                                                  Email = "Dana.Birkby@Contoso.com"
                                              },
                                          new Employee()
                                              {
                                                  Id = "4",
                                                  FirstName = "David",
                                                  LastName = "Probst",
                                                  Phone = "(425) 555 2836",
                                                  Email = "David.Probst@Contoso.com"
                                              },
                                      };
            }

            return this.employees;
        }

        public List<Project> GetProjects()
        {
            if (this.projects == null)
            {
                // Dummy data.
                this.projects = new List<Project>
                                     {
                                         new Project() {Id = "1", ProjectName = "Project 1", Role = "Dev Lead"},
                                         new Project() {Id = "1", ProjectName = "Project 2", Role = "Tech Reviewer"},
                                         new Project() {Id = "2", ProjectName = "Project 1", Role = "Test Lead"},
                                         new Project() {Id = "2", ProjectName = "Project 2", Role = "Tech Reviewer"},
                                         new Project() {Id = "3", ProjectName = "Project 1", Role = "Architect"},
                                         new Project() {Id = "3", ProjectName = "Project 2", Role = "Tech Reviewer"},
                                         new Project() {Id = "3", ProjectName = "Project 3", Role = "Tech Reviewer"},
                                         new Project() {Id = "4", ProjectName = "Project 1", Role = "Test Lead"},
                                         new Project() {Id = "4", ProjectName = "Project 2", Role = "Tech Reviewer"},
                                         new Project() {Id = "4", ProjectName = "Project 3", Role = "Tech Reviewer"},
                                         new Project() {Id = "4", ProjectName = "Project 4", Role = "Tech Reviewer"}
                                     };
            }

            return this.projects;
        }
    }
}