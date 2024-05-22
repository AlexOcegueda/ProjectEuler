CC = gcc

CFLAGS = -Wall -Wextra -std=c11 -I./Math-Library

UTILS_SRCS = Math-Library/pe-utils.c
UTILS_OBJS = $(UTILS_SRCS:.c=.o)

all: help

%.o: %.c
	$(CC) $(CFLAGS) -c $< -o $@

build: $(PROBLEM_SRC:.c=.o) $(UTILS_OBJS)
	$(CC) $(CFLAGS) -o $(PROBLEM_NAME) $^

run: build
	./$(PROBLEM_NAME)

clean:
	rm -f $(PROBLEM_NAME) $(PROBLEM_SRC:.c=.o) $(UTILS_OBJS)

help:
	@echo "Usage: make build PROBLEM_NAME=problem-6/Sum-Square-Differences PROBLEM_SRC=problem-6/Sum-Square-Differences.c"
	@echo "Example: make build PROBLEM_NAME=problem-2/some-problem-2 PROBLEM_SRC=problem-2/some-problem-2.c"

.PHONY: all clean help build
