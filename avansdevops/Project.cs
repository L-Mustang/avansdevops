﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avansdevops.SprintStrategy;
using avansdevops.DevOps;

namespace avansdevops
{
    public class Project
    {
        private ProductBacklog _productBacklog { get; set; }
        private Forum _forum { get ; set; }
        private Sprint _sprint;
        private Repository _repo { get; set; }

        public Project()
        {
            _productBacklog = new ProductBacklog();
            _forum = new Forum();
        }

        public void AddSprint(ISprintStrategy sprintStrat)
        {
            _sprint = new Sprint(sprintStrat);
        }

        public void AddRepository(string name)
        {
            _repo = new Repository(name);
        }

        public Repository GetRepository()
        {
            return _repo;
        }

        public Sprint GetSprint()
        {
            return _sprint;
        }
    }
}
