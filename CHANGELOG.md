# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## Unreleased
## 1.3.1 - 2018-05-23
### Changed
- Add actingAs parameter to Client.ListVariables and Client.ListUsers methods
- Remove Client.ActingAs property

## 1.3.0 - 2018-05-22
### Added
- User entity
- Client.ListUsers method to list for users

## 1.2.0 - 2018-04-25
### Added
- Client.ListVariables method to list for variables.
- Client.ActingAs property (currently with support limited to the above).

## 1.1.1 - 2018-03-06
### Fixed
- The built-in authenticator is now thread-safe.

## 1.1.0 - 2018-01-09
### Added
- `Variable.AddValue()` method for adding variable values.
