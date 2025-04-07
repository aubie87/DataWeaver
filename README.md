# DataWeaver
General purpose prototype to manipulate large datasets from one form to another.

Example input forms (all with their own schemas) might be XML, CSV, other structured data, unstructured data such as letters.

All need to be parsed and mapped to one or more standard output formats.

## Plan
+ Build out initial command line environment using
    + Standard argument parser using verbs
    + Command line to include --input-parser and --output-format
    + Standard dependency injection
    + Initial command line and settings.json configuration will be available.
        + Input folder
        + Output folder
        + Max thread count - when threaded processing is implemented
+ Build out initial input parser called "bogus" that uses the Bogus libray to generate data.
    + Use multiple json files to initialize the fake data to simulate loading actual data files.
    + Develop the inital mapper to go from the fake data to a separately defined XML model.
    + Eventually this data can be saved out to a format that we can then use as yet another input format
        + First real format will likely be XML based loosely on financial statements containing fake accounts and transactions.
    

For simplicty, all namespaces will be contained within the same EXE project. Eventually these libraries can be broken out and dynamically loaded based on cmd line.


