#!/bin/sh

GIO_SHARP_VERSION=2.22.2
GLIB_REQUIRED=2.22
CSC_FLAGS="-d:GIO_SHARP_2_22"

. ./autogen-generic.sh "$@"
