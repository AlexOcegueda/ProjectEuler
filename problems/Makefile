CC = gcc

CFLAGS = -Wall -Wextra -std=c11 -I./Math-Library

UTILS_SRCS = Math-Library/pe-utils.c
UTILS_OBJS = $(UTILS_SRCS:.c=.o)
PROBLEM_SRC_FILE = $(PROBLEM_SRC)
PROBLEM_OBJS = $(PROBLEM_SRC_FILE:.c=.o)

all: help

%.o: %.c
	$(CC) $(CFLAGS) -c $< -o $@

build: $(PROBLEM_OBJS) $(UTILS_OBJS)
	$(CC) $(CFLAGS) -o program $(PROBLEM_OBJS) $(UTILS_OBJS) -lc
	./program

clean:
	rm -f program $(PROBLEM_OBJS) $(UTILS_OBJS)

help:
	@echo "Usage: make build PROBLEM_NAME=problem-3/Largest-Prime-Factor PROBLEM_SRC=problem-3/Largest-Prime-Factor.c"
	@echo "Example: make build PROBLEM_NAME=problem-2/some-problem-2 PROBLEM_SRC=problem-2/some-problem-2.c"

.PHONY: all clean help build
