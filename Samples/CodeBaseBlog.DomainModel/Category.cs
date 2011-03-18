//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace CodeBaseBlog.DomainModel
{
    public partial class Category
    {
        #region Primitive Properties

        public virtual int Id { get; private set; }

        public virtual string Name { get; private set; }

        #endregion

        #region Navigation Properties

        private ICollection<Post> _posts;

        public virtual ICollection<Post> Posts
        {
            get
            {
                if (_posts == null)
                {
                    _posts = new FixupCollection<Post>();
                }
                return _posts;
            }
            set { _posts = value; }
        }

        #endregion
    }
}