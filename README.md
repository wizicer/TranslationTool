# Translation Tool

## UpdateText Usage

```
$ UpdateText source.md [translation.md]
```

## What happened?

Refer to [this file](UpdateText/UpdateTextTest.feature) for detailed example.

Here is one of them, take a look:

> *Given* I have following text in source file
> ```
> # title
> 
> hello world
> 
> ## section0 which added later
> 
> ##section1
> lorel anaditum
> 
> ## section2 -- with a long name even <span class="active">span</span> in it
> **lorel anaditum yanaghay**
> ```
> *And* I have following text in my translation file
> ```
> <!--
> # title
> 
> hello world
> 
> -->
> 
> title translation
> 
> <!--
> ##section1
> lorel anaditum
> -->
> 
> section1 translation
> 
> <!--
> ## section2 -- with a long name even <span class="active">span</span> in it
> **lorel anaditum yanaghay**
> -->
> 
> section2 translation
> ```
> *When* I try to sync
>
> *Then* I should get following text in my translation file
> ```
> <!--
> # title
> 
> hello world
> 
> -->
> 
> title translation
> 
> <!--
> ## section0 which added later
> 
> -->
> 
> <!--
> ##section1
> lorel anaditum
> 
> -->
> 
> section1 translation
> 
> <!--
> ## section2 -- with a long name even <span class="active">span</span> in it
> **lorel anaditum yanaghay**
> -->
> 
> section2 translation
> 
> ```

