VERSION := $(shell yq eval '.version' build.yaml)
BASE := "ninthclowd/jellyfin-release:$(VERSION)"

.PHONY: build

build: clean
	docker build -t $(BASE) -f Dockerfile .
	docker build -t ninthclowd/jellyfin:$(VERSION) -t ninthclowd/jellyfin:latest -f Dockerfile.ninthclowd . --build-arg BASE=$(BASE)
push:
	docker push ninthclowd/jellyfin:$(VERSION)
	docker push ninthclowd/jellyfin:latest
clean:	
	find . -not \( -path ./debian/bin -type d -prune \) -name "bin" -type d -exec rm -rf {} +;
	find . -name "obj" -type d -exec rm -rf {} +;
	