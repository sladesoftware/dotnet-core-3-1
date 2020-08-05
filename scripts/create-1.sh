#!/bin/bash

curl -kL localhost:5000/api/todo -XPUT -w '\n' \
  -H "Content-Type: application/json" \
  -d '{ "name": "TODO1", "description": "Something 1" }'

