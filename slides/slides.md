---
theme: "black"
separator: '^\r?\n---\r?\n$'
verticalSeparator: '^\r?\n--\r?\n$'
controls: false
menu: false
history: true
progress: false
slideNumber: false
mouseWheel: true
enableMenu: false
enableChalkboard: false
enableTitleFooter: false
---

# C# Source Generators

_by Jakub Šturc_

---

## About me 🤓

* Principal SW Developer @ ERNI
* Doing .NET almost half of my life
* Father of 👧👦👶
* @jakubsturc, https://jakub.sturc.eu

---

## What is a Source Generator

Roslyn Analyzer that can emit C# source code during compilation.

--

![Source Generator](slides/source-generator.png)

---

## Disclaimer ⚠

* This is 2 weeks old preview
  * Tooling is not ready yet
  * Things will change
  * Do not expect 1.0 quality
* I am not expert

---

## Prerequisites 📌

* .NET 5 Preview
* Visual Studio 2019 Preview
  * I am using 16.6.0 Preview 6

note:
VS won't be required in a future versions

---

## Demo 1 👨‍💻

note:

* show hello world
  * class is not there
  * intellisense
* show XmlSettings
  * add attribute
  * show intellisense
  * show how to debug
* ignore I notify change
* show Console highjack

--

### We saw ... 👓

* Intellisense
* Disassembly
* Debug generated code
* Debug generator

---

## Some good use cases ✅

* Generate C# from non-C# files
* Serialization
* Automatic interface implementation
* Class wrapping
* ... your idea 💡

---

## Not good fit ⛔

* Modify source code
* Implement a new language feature
* AOP (really?)

---

## Demo 2 👨‍💻

---

## Comparison with T4 ⚖

* Both are not rewriting existing code
* T4 can generate any file (not just C#)
* T4 depends on Visual Studio & Windows
* Source Generators runs inside compiler

---

## References 🔗

* [Introducing C# Source Generators](https://devblogs.microsoft.com/dotnet/introducing-c-source-generators/)
* [Source Generators Cookbook](https://github.com/dotnet/roslyn/blob/master/docs/features/source-generators.cookbook.md)

---

## Questions 🤔

---

## Thank you 🍻
