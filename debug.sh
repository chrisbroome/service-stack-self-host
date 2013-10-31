#!/bin/sh
mono --gc=sgen --debug ./build/sample.exe "$@"
