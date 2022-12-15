# Purpose

This project solution is a learning tool using .NET 7 to have a API and (eventually) a React UI talking to each other.

## Tech Used

- .NET 7
- OpenApi
- Minimal API (in terms of *calling* the API)

# Status

Currently, a bare-bones skeleton for the eventual goal.  Runs in debug only for now, via the UI's launch settings environment variable for the API url.

# Details

## Data

- The lab data is currently mocked up, coming in through json files loaded as part of the API's app configuration.
- I chose to separate the api from the ui, instead of the usual minimal API approach of putting everything into the web front-end app -- sse *Separation of Concerns*

## Design
### Separation of Concerns

#### No to API+UI in the Same App

Combining api calls, even minimal api calls, with the ui is not a favored approach of mine under most circumstances. If a really simple case, sure, but in most cases the api and the ui are going to have to scale and are going to be live for a length of time long enough to consider maintainability in the design.

# Iterations

## Phase 1

1. Created the base UI project (empty ASP.NET web core)
1. Made sure the UI ran as scaffolded
1. Created the base API project
1. Validated the API spun up with swagger
1. Added code to the API for mocking the data and confirmed in Swagger
1. Added OpenApi to the UI project to point to the API, including passing the API url into the UI's app configuration (for DEBUG only)
1. Added a query to the API from the UI, doing a simple console dump

## Phase 2

1. Add to the API other necessary GETs and confirm in swagger
1. Dump all in the UI

## Phase 3

1. Add React to the UI, basic one-page, equivalent to the phase 2 dumps
1. 
