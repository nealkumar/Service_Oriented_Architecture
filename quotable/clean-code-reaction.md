# Reaction to Clean Code for .NET

### Identify one point that illustrated something not to do that you do or tend to do.
"Only comment things that have business logic complexity." I tend to fall into a weird pattern when I comment
where there's either too much (especially for HW or interviews), or pretty much nothing at all. This may be because I assume the worst about the future
reader of my comments, which can actually be a good thing. However, I need to work on being more consise, and
focussing comments only where there is a reasonable amount of complexity.
### Identify one point that surprised you and explain why
I thought the point about using not using a Singleton pattern was valid and interesting. They bring up that a side-effect of Singleton overuse is 
"code smell" (great term). I tend to agree, except for graphics (say in the case of having a JFrame with hundreds of JPanels), creator type of objects (factories, builders, etc.).
### Identify one point that you disagree with, if any, and why
"Use Camelcase notation for methods." Java vs. C# - I think Java wins this. If both [non-constant] variables and methods are class members, 
shouldn't their casing be the same? Yup, that's what I thought, <i>public static void <b>main()</b></i> FTW.
