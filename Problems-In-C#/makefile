# Define variables for the project directory
PROBLEM_DIR ?= .

# Target to build and run the project
run:
	@echo "Building and running project in $(PROBLEM_DIR)..."
	dotnet run --project $(PROBLEM_DIR)

# Target to clean the project
clean:
	@echo "Cleaning project in $(PROBLEM_DIR)..."
	dotnet clean $(PROBLEM_DIR)

# Target to display help
help:
	@echo "Makefile for building and running .NET projects"
	@echo "Usage:"
	@echo "  make run PROBLEM_DIR=Problem-X    - Build and run the specified project"
	@echo "  make clean PROBLEM_DIR=Problem-X  - Clean the specified project"
	@echo "  make help                         - Show this help message"
	@echo ""
	@echo "Defaults:"
	@echo "  PROBLEM_DIR = ."

# Default target
.DEFAULT_GOAL := help
