using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06PageDisenio2
{
    class PersonRepository
    {
        public IList<Person> GetPersons { get; private set; }

        public PersonRepository()
        {
            GetPersons = new List<Person> {
                new Person { Name = "Alex Silveira", Email = "egestas@anequeNullam.co.uk", Fone="9985-5623" },
                new Person { Name = "Wilson Martin", Email = "a.tortor@Sed.net",  Fone ="9985-5623" },
                new Person { Name = "Osmar Moss", Email = "tristique@faucibusutnulla.net", Fone ="9985-5623" },
                new Person { Name = "Yasmim Dudley", Email = "montes.nascetur.ridiculus@fringillaest.ca", Fone ="9985-5623" },
                new Person { Name = "Yoshio Anthony", Email = "ut.aliquam.iaculis@pharetraNam.edu" , Fone ="9985-5623"},
                new Person { Name = "Valentina Poole", Email = "auctor@consectetuer.org" , Fone ="9985-5623"},
                new Person { Name = "Armando Tillman", Email = "facilisis.vitae.orci@liberolacusvarius.com" , Fone ="9985-5623"},
                new Person { Name = "Klaus Hickman", Email = "Pellentesque.habitant@tristiqueaceleifend.org" , Fone ="9985-5623" },
                new Person { Name = "Levi Marshall", Email = "imperdiet.ullamcorper@Quisque.com" , Fone="9985-5623" },
                new Person { Name = "Norberto Boone", Email = "adipiscing@anteipsum.ca" , Fone ="9985-5623" },
                new Person { Name = "Emerlindo Mendez", Email = "aliquet.molestie.tellus@Nam.net" , Fone ="9985-5623" },
                new Person { Name = "Marcos Compton", Email = "Etiam.bibendum.fermentum@malesuadaIntegerid.co.uk" , Fone ="9985-5623" },
                new Person { Name = "Braulio Chapman", Email = "lacinia.orci@aliquetdiamSed.ca" , Fone ="9985-5623" },
                new Person { Name = "Heleno Roberson", Email = "gravida@Nunc.edu" , Fone ="9985-5623" },
                new Person { Name = "Yuri Herrera", Email = "velit@erat.org" , Fone ="9985-5623" },
                new Person { Name = "Lucas Brown", Email = "magnis@Cumsociis.org" , Fone ="9985-5623" },
                new Person { Name = "Gilson Reilly", Email = "vel@NullamenimSed.com" , Fone ="9985-5623" },
                new Person { Name = "Arsenio Suarez", Email = "ridiculus.mus.Aenean@tellusfaucibusleo.co.uk" , Fone ="9985-5623" },
                new Person { Name = "Igor Mclaughlin", Email = "ut.lacus.Nulla@Aliquamnec.edu" , Fone ="9985-3023" },
                new Person { Name = "Carla Craft", Email = "Etiam.gravida.molestie@rutrummagna.ca" , Fone ="9985-3023" },
                new Person { Name = "Benedito Carson", Email = "adipiscing@enimMauris.edu" , Fone ="9985-3023" },
                new Person { Name = "Roberto Reynolds", Email = "commodo@sapienmolestie.edu" , Fone ="9985-3023" },
                new Person { Name = "Denis Webb", Email = "sit.amet.consectetuer@Loremipsumdolor.org" , Fone ="9985-2123" },
                new Person { Name = "Jacob Singleton", Email = "sem.consequat@vehiculaPellentesque.co.uk" , Fone="9985-2123" },
                new Person { Name = "Carina Tucker", Email = "molestie@erosturpis.ca" , Fone ="9985-2123" },
                new Person { Name = "Felix Holder", Email = "sollicitudin.a@Curae.co.uk" , Fone ="9985-1123" },
                new Person { Name = "Mateus Reid", Email = "Etiam.bibendum@Donecat.edu" , Fone ="9985-1123" },
                new Person { Name = "Anabel Noel", Email = "rhoncus.Donec@vel.edu" , Fone ="9985-4123" },
                new Person { Name = "Karina Dunlap", Email = "lectus@risusQuisque.co.uk" , Fone ="9985-3123" },
                new Person { Name = "Silvio Ewing", Email = "cubilia@afeugiattellus.ca" , Fone ="9985-5123" },
                new Person { Name = "Lucas Reed", Email = "id.risus@Aliquam.edu" , Fone ="9985-4423" },
                new Person { Name = "Geraldo Huff", Email = "non.arcu.Vivamus@fames.edu" , Fone ="9985-0923" },
                new Person { Name = "Fernando Carroll", Email = "ut.nisi.a@elit.edu" , Fone ="9985-0923" },
                new Person { Name = "Leonardo Hamilton", Email = "vitae@penatibusetmagnis.net" , Fone ="9985-0923" },
                new Person { Name = "Myles Knowles", Email = "vitae.aliquam@magna.org" , Fone ="9985-0923" },
                new Person { Name = "Cristina Schmidt", Email = "imperdiet.dictum.magna@vitaeerat.org" , Fone ="9985-0923" },
                new Person { Name = "Thais Ball", Email = "Cras.eu@ataugue.net" , Fone ="9985-0923" },
                new Person { Name = "Renato Mclean", Email = "leo@vitaenibh.net" , Fone ="9985-2323" },
                new Person { Name = "Celio Rogers", Email = "eros.turpis.non@ettristique.co.uk" , Fone ="9985-1023" },
                new Person { Name = "Otavio Estes", Email = "vel@ac.edu" , Fone ="9985-7723"},
            };
        }
    }
}
