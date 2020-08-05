#!/bin/bash

curl -kL localhost:5000/api/todo/2 -XPATCH -w '\n' \
  -H "Content-Type: application/json" \
  -d '{ "name": "Second Item", "description": "Another thing to-do..." }'

