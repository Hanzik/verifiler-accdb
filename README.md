# VerifilerACCDB - Verifiler plugin
              
[GitHub](https://github.com/Hanzik/verifiler-accdb) | [NuGet](https://www.nuget.org/packages/VerifilerACCDB/)

Optional library for [Verifiler](https://github.com/Hanzik/verifiler), a .NET file validation and verification library which allows users to verify integrity of the
following file formats:

  * .accdb

---

## Installation

Download the package via [NuGet](https://www.nuget.org/packages/VerifilerACCDB/) or acquire the .dll any other way and place it
in the executing location (usually bin/Debug or bin/Release). If you are not sure, find the location by printing the value of
**Assembly.GetExecutingAssembly().Location**.
       
---

## List of optional verification libraries

You can install the following libraries (via NuGet) if you want to detect files which
may have been corrupted during transfer (or any other reason). 

  * **VerifilerACCDB** ([GitHub](https://github.com/Hanzik/verifiler-accdb) | [NuGet](https://www.nuget.org/packages/VerifilerACCDB/)) - .accdb 
  * **VerifilerImage** ([GitHub](https://github.com/Hanzik/verifiler-image) | [NuGet](https://www.nuget.org/packages/VerifilerImage/)) - .jpg, .png
  * **VerifilerMSLegacy** ([GitHub](https://github.com/Hanzik/verifiler-mslegacy) | [NuGet](https://www.nuget.org/packages/VerifilerMSLegacy/)) - .xls 
  * **VerifilerODF** ([GitHub](https://github.com/Hanzik/verifiler-odf) | [NuGet](https://www.nuget.org/packages/VerifilerODF/)) - .ods, .odt
  * **VerifilerOpenXML** ([GitHub](https://github.com/Hanzik/verifiler-openxml) | [NuGet](https://www.nuget.org/packages/VerifilerOpenXML/)) - .docx, .pptx, .xlsx
  * **VerifilerPDF** ([GitHub](https://github.com/Hanzik/verifiler-pdf) | [NuGet](https://www.nuget.org/packages/VerifilerPDF/)) - .pdf


## List of other relevant repositories
                                    
  * **Verifiler** ([GitHub](https://github.com/Hanzik/verifiler) | [NuGet](https://www.nuget.org/packages/Verifiler/)) - Core library containing classes required by all other Verifiler libraries.
  * **VerifilerCore** ([GitHub](https://github.com/Hanzik/verifiler-core) | [NuGet](https://www.nuget.org/packages/VerifilerCore/)) - Core library containing classes required by all other Verifiler libraries.
  * **VerifilerTest** ([GitHub](https://github.com/Hanzik/verifiler-test)) - Unit test library.
