using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.DevOps
{
    public class Repository
    {
        private string _name;
        private List<Branch> _branches;

        public Repository(string name)
        {
            _name = name;
            _branches = new List<Branch>();

            _branches.Add(new Branch("main"));

        }
        public void AddBranch(Branch branch)
        {
            _branches.Add(branch);
        }

        public void RemoveBranch(Branch branch)
        {
            _branches.Remove(branch);
        }

        public List<Branch> GetAllBranches()
        {
            return _branches;
        }

        public Branch? GetUser(string branchName)
        {
            return _branches.Find(x => x.Name == branchName);
        }

        public string GetName()
        {
            return _name;
        }

        public string? ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Repository)
            {
                var that = obj as Repository;
                return _name == that._name;
            }
            return false;
        }
    }
}
