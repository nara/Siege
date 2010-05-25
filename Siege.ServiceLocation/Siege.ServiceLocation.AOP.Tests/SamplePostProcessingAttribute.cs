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

using System;
using Siege.ServiceLocation.AOP.Attributes;

namespace Siege.ServiceLocation.AOP.Tests
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SamplePostProcessingAttribute : Attribute, IDefaultPostProcessingAttribute
	{
		public void Process()
		{
		}
	}
}