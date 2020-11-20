using System;
using System.ComponentModel.DataAnnotations;

using VNC.Core.DomainServices;
// Template Parameters
// clrversion             4.0.30319.42000
// itemname               TYPE
// machinename            CA154-L-6NGM5S2
// projectname            $projectname$
// registeredorganization 
// rootnamespace          VNC_PT_APPLICATION_WPF.Domain
// safeitemname           TYPE
// safeitemrootname       TYPE
// safeprojectname        $safeprojectname$
// time                   7/29/2020 3:49:46 PM
// specifiedsolutionname  $specifiedsolutionname$
// userdomain             BDX
// username               10298093
// webnamespace           $webnamespace$
// year                   2020

namespace VNC_PT_APPLICATION_WPF.Domain
{
    public class TYPE : IEntity<int>, IModificationHistory
    {
        #region IEntity<int>

        public int Id { get; set; }

        #endregion

        // TODO(crhodes)
        // Examples with each different datatype

        [StringLength(50)]
        public string FieldString { get; set; }

        public int FieldInt { get; set; }

        public double FieldDouble { get; set; }

        public Single FieldSingle { get; set; }

        public DateTime FieldDate { get; set; }

        #region IModificationHistory

        public DateTime? DateModified { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool? IsDirty { get; set; }

        #endregion
    }
}
