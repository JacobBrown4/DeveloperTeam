using DeveloperTeam.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeam
{
    public class Repository
    {
        private readonly List<Team> _employeeDirectory = new List<Team>();

        // CREATE
        public void AddTeamToDirectory(Team content)
        {
            _employeeDirectory.Add(content);
        }

        // READ
        // Get All DeveloperTeam
        public List<Team> GetDirectory()
        {
            return _employeeDirectory;
        }

        // Get One DeveloperTeam By Title
        public Team GetTeamByID(int id)
        {
            foreach (Team item in _employeeDirectory)
            {
                if (item.TeamID == id)
                {
                    return item;
                }
            }

            return null;
        }

        //// UPDATE
        //public bool UpdateExistingContent(Team updatedContent, string originalTitle)
        //{
        //    Team content = GetTeamByID(Team id);
        //    if (content != null)
        //    {
        //        int itemIndex = _employeeDirectory.IndexOf(content);
        //        _employeeDirectory[itemIndex] = updatedContent;
        //        return true;
        //    }

        //    return false;
        //}

        // DELETE
        public bool DeleteExistingContent(Team item)
        {
            return _employeeDirectory.Remove(item);
        }


        public bool DeleteTeamByID(int id)
        {
            Team targetContent = GetTeamByID(id);
            return DeleteExistingContent(targetContent);
        }
    }
}
