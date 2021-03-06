/*   Copyright 2009 - 2010 Marcus Bratton

     Licensed under the Apache License, Version 2.0 (the "License");
     you may not use this file except in compliance with the License.
     You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

     Unless required by applicable law or agreed to in writing, software
     distributed under the License is distributed on an "AS IS" BASIS,
     WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
     See the License for the specific language governing permissions and
     limitations under the License.
*/

using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace Siege.Repository.NHibernate.Conventions
{
    public class ReferenceConvention : IReferenceConvention
    {
        public void Apply(IManyToOneInstance instance)
        {
            instance.Column(instance.Property.Name + ConventionConstants.Id);
            instance.ForeignKey(string.Format("FK_{0}_{1}_{2}",
                                              instance.EntityType.Name + ConventionConstants.TableSuffix,
                                              instance.Property.Name + ConventionConstants.TableSuffix,
                                              instance.Property.Name + ConventionConstants.Id));
        }
    }
}