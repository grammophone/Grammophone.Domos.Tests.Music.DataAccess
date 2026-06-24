# Grammophone.Domos.Tests.Music.DataAccess

Provider-neutral data access contract for the Domos music test application.

This project exposes the `IMusicDomosDomainContainer` abstraction used by the music logic and provider-specific EF6 / EF Core data access projects.

## Target Frameworks

- `net472`
- `netstandard2.1`

## Required Projects

This project expects these sibling projects to be available when building from the solution or from extracted submodules:

- `Grammophone.DataAccess`
- `Grammophone.Domos.DataAccess`
- `Grammophone.Domos.Tests.Music.Domain`
