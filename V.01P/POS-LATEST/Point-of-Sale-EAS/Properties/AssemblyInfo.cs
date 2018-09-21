using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("CALCIUM RMS V1.0")]
[assembly: AssemblyDescription("Point of Sale Management Solution")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Calcium Solutions")]
[assembly: AssemblyProduct("CALCIUM RMS V1.0")]
[assembly: AssemblyCopyright("Copyright © Calicum 2013")]
[assembly: AssemblyTrademark("CA-RMS")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("a42197db-ed2c-422f-a177-aaac47486e4e")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.1.3114")]
[assembly: AssemblyFileVersion("1.0.1.3114")]

[assembly: ObfuscateAssembly(true)]
[assembly: Obfuscation(Feature = "all /namespace:Calcium_RMS.Text", ApplyToMembers = true)]
[assembly: Obfuscation(Feature = "all /namespace:Microsoft.Office.Interop", ApplyToMembers = true)]
[assembly: ObfuscationAttribute( Feature="preserve-identity")]
[assembly: ObfuscationAttribute( Feature="add-prefix /prefix:SariKingAntiHackingEngine")]
[assembly: ObfuscationAttribute( Feature="preserve-performance")]

