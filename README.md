# Abp

# Develop

# Release

1. Bump version 
> edit common.abp.props -f Makefile.abp
2. Run (cygwin)
> make clean
3. Run (powershell)
> make build Config=Release -f Makefile.abp

# Deploy
1. Run 
> make deploy -f Makefile.deploy NugetSource=xx


# Polp

# Develop

# Release

1. Bump version 
> edit common.polp.props
2. Run (cygwin)
> make clean -f Makefile.polp
3. Run (powershell)
> make build Config=Release -f Makefile.polp

# Deploy
1. Run 
> make deploy -f Makefile.deploy NugetSource=xx
