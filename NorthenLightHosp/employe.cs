//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthenLightHosp
{
    using System;
    using System.Collections.Generic;
    
    public partial class employe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employe()
        {
            this.commentaire_patient = new HashSet<commentaire_patient>();
            this.dossier_admission = new HashSet<dossier_admission>();
        }
    
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string nom_utilisateur { get; set; }
        public string mot_passe { get; set; }
        public int id_role { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commentaire_patient> commentaire_patient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dossier_admission> dossier_admission { get; set; }
        public virtual role role { get; set; }
    }
}
