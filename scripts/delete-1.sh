#!/bin/bash

curl -kL localhost:5000/api/todo/1 -XDELETE -w '\n'

