using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Organisations.DataSource
{
    internal class Organization
    {
        int index;
        string organizationId;
        string name;
        string website;
        string country;
        string description;
        int founded;
        string industry;
        int numberOfEmployees;

        public Organization(int index, string organizationId, string name, string website, string country, string description, int founded, string industry, int numberOfEmployees)
        {
            this.index = index;
            this.organizationId = organizationId;
            this.name = name;
            this.website = website;
            this.country = country;
            this.description = description;
            this.founded = founded;
            this.industry = industry;
            this.numberOfEmployees = numberOfEmployees;
        }

        public int Index { get => index; set => index = value; }
        public string OrganizationId { get => organizationId; set => organizationId = value; }
        public string Name { get => name; set => name = value; }
        public string Website { get => website; set => website = value; }
        public string Country { get => country; set => country = value; }
        public string Description { get => description; set => description = value; }
        public int Founded { get => founded; set => founded = value; }
        public string Industry { get => industry; set => industry = value; }
        public int NumberOfEmployees { get => numberOfEmployees; set => numberOfEmployees = value; }
    }
}
