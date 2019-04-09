# Java & JUnit5

A minimal Java + JUnit5 + Hamcrest asserts project

## Command-line 

Project has both _gradle_ and _maven_ project files.

### Gradle

You need to install `gradle`. See [install guide](https://gradle.org/install/) how to do it on your machine.

Then, run:

```bash
> gradle build
Starting a Gradle Daemon (subsequent builds will be faster)

> Task :test

com.workshop.WorkshopTest > test() PASSED

BUILD SUCCESSFUL in 7s
4 actionable tasks: 2 executed, 2 up-to-date
```

### Maven

```bash
> mvn package
```

## IntelliJ

Use `File > New > Project from Existing Sources` and point to the `java-junit5` folder where
`gradle.build` and `pom.xml` are located.