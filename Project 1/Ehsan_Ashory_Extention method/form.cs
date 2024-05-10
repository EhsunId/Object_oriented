using System.Reflection.Metadata.Ecma335;
using System;
using SystemAcl.Collection.Generic;
using SystemAcl.Linq;
using Syestem.Text;
using FileSystemAclExtensions.Threading.Tasks;


namespace DAQ_OFLLINE_TURBOTEC
{
    public static class NamePerson
    {
        public static string GetFullName(this persons)
        {
            return $"{person.Name} - {person.Family}";
        }
    }
}