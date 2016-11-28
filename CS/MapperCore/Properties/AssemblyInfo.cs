﻿using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

//  Les informations générales relatives à un assembly dépendent de 
//  l'ensemble d'attributs suivant. Changez les valeurs de ces attributs pour modifier les informations
//  associées à un assembly.
[assembly: AssemblyTitle("MapperExpression")]
[assembly: AssemblyDescription("Mapper simple like AutoMapper based on the lambda expressions")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Laurent Boulet")]
[assembly: AssemblyProduct("MapperExpression")]
[assembly: AssemblyCopyright("Copyright © Me 2016")]
[assembly: AssemblyTrademark("MapperExpression")]
[assembly: AssemblyCulture("")]

//  L'affectation de la valeur false à ComVisible rend les types invisibles dans cet assembly 
//  aux composants COM. Si vous devez accéder à un type dans cet assembly à partir de 
//  COM, affectez la valeur true à l'attribut ComVisible sur ce type.
[assembly: ComVisible(false)]

//  Le GUID suivant est pour l'ID de la typelib si ce projet est exposé à COM
[assembly: Guid("a339b173-2ba4-44df-8654-4b0e6d6b9cd0")]

//  Les informations de version pour un assembly se composent des quatre valeurs suivantes :
// 
//       Version principale
//       Version secondaire 
//       Numéro de build
//       Révision
// 
//  Vous pouvez spécifier toutes les valeurs ou indiquer les numéros de build et de révision par défaut 
//  en utilisant '*', comme indiqué ci-dessous :
//  [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.*")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: InternalsVisibleTo("MapperExpression.Tests.Units")]
[assembly: InternalsVisibleTo("MapperExpression.Fakes")]
[assembly: CLSCompliant(true)]