﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Lockdown.AcceptanceTests.Roles
{
    [Binding]
    public class Steps
    {
        private IEnumerable<Role> _result;

        [When(@"I get the list of roles")]
        public void WhenIGetTheListOfRoles()
        {
            _result = TestContext.Store.GetRoles();
        }

        [Given(@"the store has no roles")]
        public void GivenTheStoreHasNoRoles()
        {
        }

        [Then(@"I get a list of roles with 2 items in it")]
        public void ThenIGetAListOfRolesWith2ItemsInIt()
        {
            Assert.That(_result, Is.Not.Null);
            Assert.That(_result.Count(), Is.EqualTo(2));
        }

        [Then(@"I get a list with a role called (.*) in it")]
        public void ThenIGetAListWithARoleCalledRole1InIt(string name)
        {
            Assert.That(_result, Is.Not.Null);
            Assert.That(_result.Any(r => r.Name.Equals(name)), Is.True);
        }

        [Then(@"I get an empty list of roles")]
        public void ThenIGetAnEmptyList()
        {
            Assert.That(_result, Is.Not.Null);
            Assert.That(_result.Count(), Is.EqualTo(0));
        }
    }
}