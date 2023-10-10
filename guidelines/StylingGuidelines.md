---
uid: G.StylingGuidelines
title: StylingGuidelines
---
# Styling Guidelines

# Razor files

- Arguments to Material.Blazor components broadly to be placed on separate lines in alphabetical order, except:
  - The `@attributes` argument splats generated and unmatched attributes on to tags. Blazor applies attributes on a right to left basis, prioritising the first that it encounters (i.e. the rightmost attribute). As a result the `@attributes` parameter is always VERY CAREFULY PLACED and should never be moved - assume that its placement was considered very carefully.

# C# files

The content of a c# file is broken into sections most of which use regions to aid in the comprehension of the content. The sections follow a strict order. 
- using
  - All 'using' statements begin the source file. They are arranged by using the right click 'Remove and Sort Usings' command which will alphabetize the entries and separate them into groups based upon the first portion of the name. 
- namespace
  - The namespace is specified using the C# 10 file scoped namespace.
- class
  - The class declaration and its supporting open/close braces do not reside in a region.
- members
- ctor
- individual methods and internal classes



