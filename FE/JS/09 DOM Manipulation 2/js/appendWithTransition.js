export default function appendWithTransition(container, node, transition) {
  node.classList.add(transition);
  container.appendChild(node);
  setTimeout(() => {
    node.classList.remove(transition);
  });
}