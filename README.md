# libspinners-dotnet

[![](https://img.shields.io/github/v/tag/thechampagne/libspinners-dotnet?label=version)](https://github.com/thechampagne/libspinners-dotnet/releases/latest) [![](https://img.shields.io/github/license/thechampagne/libspinners-dotnet)](https://github.com/thechampagne/libspinners-dotnet/blob/main/LICENSE)

.NET binding for **libspinners** an elegant terminal spinners.

### Example

```cs
using Spinners;

var spin = new Spinner(Spinner.Spinners.Dots9, "Waiting for 3 seconds");
System.Threading.Thread.Sleep(3000);
spin.Stop();
```

### References
 - [libspinners](https://github.com/thechampagne/libspinners)

### License

This repo is released under the [MIT](https://github.com/thechampagne/libspinners-dotnet/blob/main/LICENSE).
