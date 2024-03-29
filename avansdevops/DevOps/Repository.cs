﻿using System;
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

        public Branch? GetBranch(string branchName)
        {
            return _branches.Find(x => x.Name == branchName);
        }

        public string GetName()
        {
            return _name;
        }
    }
}
