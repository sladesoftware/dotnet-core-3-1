#!/bin/bash

curl -kL localhost:5000/api/todo -XPUT -w '\n' \
  -H "Content-Type: application/json" \
  -d '{ "name": "TODO2", "description": "Something 2" }'

