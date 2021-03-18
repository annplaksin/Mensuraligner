# Mensuraligner

[![DOI](https://zenodo.org/badge/164682221.svg)](https://zenodo.org/badge/latestdoi/164682221)

The Mensuraligner reads encodings of mensural music sources in MEI and performs pairwise alignments and Neighbor-Joining analyis. 
In addition, it can be used to run a surrogate analysis for the alignments. This will generate a number of randomly scrambled sequences 
from two original sequences and run a pairwise alignment on the original sequences and on the pairs of scrambled sequences.

The Neighbor-Joining result is a tree in the [Newick format](https://evolution.genetics.washington.edu/phylip/newicktree.html). Please 
use a software like DRAWTREE from the [PHYLIP](https://evolution.genetics.washington.edu/phylip.html) package to draw an unrooted tree.

For more information, see: 
* Plaksin, Anna Viktoria Katrin: "Modelle zur computergestützten Analyse von Überlieferungen 
	der Mensuralmusik. Emprische Textforschung im Kontext phylogenetischer Verfahren.", Münster, 2021 
	(Schriften zur Musikwissenschaft aus Münster 27), online: [urn:nbn:de:hbz:6-59029717067](http://nbn-resolving.de/urn:nbn:de:hbz:6-59029717067),  DOI: [10.26083/tuprints-00017211](https://doi.org/10.26083/tuprints-00017211).
* Anna Plaksin: "Do visual features matter? Studies in phylogenetic analysis of mensural music", in: Music Encoding Conference 2020, 
	edited by Elsa de Luca and Julia Flanders. 2020; DOI: [10.17613/pzy7-ek18](http://dx.doi.org/10.17613/pzy7-ek18)
* Anna Plaksin: "Differenz und Ähnlichkeit in der computergestützten Filiation von Renaissancemusik. 
	Zur datenbasierten Evaluation von Substitutionsmodellen mithilfe von Surrogatdaten", in: DHd 2020 Spielräume: Digital Humanities zwischen Modellierung und Interpretation. 
	Konferenzabstracts, hrsg. von Christof Schöch, 119-122. 2020. DOI: [10.5281/zenodo.3666690](http://doi.org/10.5281/zenodo.3666690)

## Compilation and Usage

The application is implemented in C#. This repository contains a Visual Studio 2019 project. 
After cloning, it can be compiled using Visual Studio.

## Dependencies

* .NET Framework 4.6.1
	* Linq to Xml
	* MSTest Visual Studio Unit Testing 1.3, see [Getting started with unit testing](https://docs.microsoft.com/en-us/visualstudio/test/getting-started-with-unit-testing?view=vs-2019)
* [libmei.NET](https://github.com/annplaksin/libmei), .NET based C# implementation of libmei, developed by Andrew Hankinson and Alastair Porter, see [DDMAL/libmei](https://github.com/DDMAL/libmei)
* [mei-Mensural_sourceEncoding](https://github.com/annplaksin/mensural_sourceEncoding) MEI customization. Two samples encodings are part of the unit tests.
* Fraction Class in C# Version 2.3 by Syed Mehroz Alam, Marc Brooks and Jeffrey Sax (published under CPOL license), see [Code Project: Fraction class in C#](https://www.codeproject.com/Articles/9078/Fraction-class-in-C)

## Acknowledgements

Many thanks to [Andreas Prohl-Plaksin](https://github.com/Prohl) for his support!
