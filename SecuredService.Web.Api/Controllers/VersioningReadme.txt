Versioning of the Web.Api controllers can be done a couple different ways.

Microsoft recommeds using the build it attribute routing - which plays nice with the generated service help pages (if the nuget is installed)

An alternative is to implement your own IHttpControllerSelector - which would allow for a more convention based approach.

See this article for more information.

http://blogs.msdn.com/b/webdev/archive/2014/08/22/customizing-web-api-controller-selector.aspx